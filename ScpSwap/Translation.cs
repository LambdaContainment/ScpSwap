// -----------------------------------------------------------------------
// <copyright file="Translation.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace ScpSwap
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using PlayerRoles;
    using ScpSwap.Configs;
    using ScpSwap.Models;

    /// <inheritdoc />
    public class Translation : ITranslation
    {
        /// <summary>
        /// Gets or sets a collection of custom names with their correlating <see cref="RoleTypeId"/>.
        /// </summary>
        [Description("A collection of custom names with their correlating RoleType.")]
        public Dictionary<string, RoleTypeId> TranslatableSwaps { get; set; } = new Dictionary<string, RoleTypeId>
        {
            { "173", RoleTypeId.Scp173 },
            { "peanut", RoleTypeId.Scp173 },
            { "939", RoleTypeId.Scp939 },
            { "079", RoleTypeId.Scp079 },
            { "79", RoleTypeId.Scp079 },
            { "computer", RoleTypeId.Scp079 },
            { "106", RoleTypeId.Scp106 },
            { "larry", RoleTypeId.Scp106 },
            { "096", RoleTypeId.Scp096 },
            { "96", RoleTypeId.Scp096 },
            { "shyguy", RoleTypeId.Scp096 },
            { "049", RoleTypeId.Scp049 },
            { "49", RoleTypeId.Scp049 },
            { "doctor", RoleTypeId.Scp049 },
            { "0492", RoleTypeId.Scp0492 },
            { "492", RoleTypeId.Scp0492 },
            { "zombie", RoleTypeId.Scp0492 },
            { "3114", RoleTypeId.Scp3114 },
            { "skeleton", RoleTypeId.Scp3114 },
        };

        /// <summary>
        /// Gets or sets the message to be displayed to all Scp subjects at the start of the round.
        /// </summary>
        [Description("The message to be displayed to all Scp subjects at the start of the round.")]
        public Broadcast StartMessage { get; set; } = new Broadcast("<color=yellow><b>Você sabia que você pode trocar de SCP?</b></color> Simplesmente digite <color=orange>.trocar (número do SCP)</color> no seu console (não o RA)!", 15);

        /// <summary>
        /// Gets or sets the broadcast to display to the receiver of a swap request.
        /// </summary>
        [Description("The broadcast to display to the receiver of a swap request.")]
        public Broadcast RequestBroadcast { get; set; } = new Broadcast("<i>Você tem uma solicitação de troca de SCP!\nVerifique seu console pressionando [`] ou [~]</i>", 5);

        /// <summary>
        /// Gets or sets the console message to send to the receiver of a swap request.
        /// </summary>
        [Description("The console message to send to the receiver of a swap request.")]
        public ConsoleMessage RequestConsoleMessage { get; set; } = new ConsoleMessage("Você recebeu uma solicitação de troca de $SenderName que é $RoleName. Gostaria de trocar com ele? Digite \".trocar aceitar\" para aceitar ou \".trocar recusar\" para recusar.", "yellow");

        /// <summary>
        /// Gets or sets the console message to send to players when the swap succeeds.
        /// </summary>
        [Description("The console message to send to players when the swap succeeds.")]
        public ConsoleMessage SwapSuccessful { get; set; } = new ConsoleMessage("Troca bem sucedida!", "green");

        /// <summary>
        /// Gets or sets the console message to send to the receiver of a swap request that has timed out.
        /// </summary>
        [Description("The console message to send to the receiver of a swap request that has timed out.")]
        public ConsoleMessage TimeoutReceiver { get; set; } = new ConsoleMessage("Sua solicitação de troca expirou.", "red");

        /// <summary>
        /// Gets or sets the console message to send to the sender of a swap request that has timed out.
        /// </summary>
        [Description("The console message to send to the sender of a swap request that has timed out.")]
        public ConsoleMessage TimeoutSender { get; set; } = new ConsoleMessage("O jogador não respondeu à sua solicitação.", "red");

        /// <summary>
        /// Gets or sets the various command instances to be translated.
        /// </summary>
        [Description("The various command instances to be translated.")]
        public CommandTranslations CommandTranslations { get; set; } = new CommandTranslations();
        
        public string NotEnoughScpsTo079 { get; set; } = "Você não pode trocar para SCP-079 porque não há SCPs suficientes na rodada.";
        public string CantSwapTo3114 { get; set; } = "Você não pode trocar para SCP-3114, bobinho.";
        public string CantSwapTo0492 { get; set; } = "Você não pode trocar para SCP-049-2, bobinho.";
        public string ExecutorIsntPlayer { get; set; } = "O comando deve ser executado no jogo.";
        public string RoundIsntStarted { get; set; } = "A rodada ainda não começou.";
        public string SwapPeriodEnded { get; set; } = "O período de troca terminou.";
        public string AllowUserSwapByPermission { get; set; } = "Você não tem permissão para usar este comando.";
        public string NotAnScp { get; set; } = "Você deve ser um SCP para usar este comando.";
        public string AlreadyHasPendingRequest { get; set; } = "Você já tem uma solicitação de troca pendente!";
        public string CannotSwapWithYourself { get; set; } = "Você não pode trocar com você mesmo.";
        public string CannotSwapOffThisScp { get; set; } = "Você não tem permissão para trocar deste SCP.";
        public string RequestSent { get; set; } = "Solicitação de troca enviada!";
        public string CannotFindRole { get; set; } = "Não foi possível encontrar o cargo especificado";
        public string SuccessfulSwap { get; set; } = "Troca bem sucedida.";
        public string CannotFindPlayerWithRole { get; set; } = "Não foi possível localizar um jogador com o cargo solicitado.";
        public string NoPendingRequest { get; set; } = "Você não tem uma solicitação de troca pendente.";
        public string SwapRequestCancelled { get; set; } = "Solicitação de troca cancelada.";
    }
}