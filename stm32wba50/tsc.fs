\
\ @file tsc.fs
\ @brief Touch sensing controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TSC_DEF

  [ifdef] TSC_TSC_CR_DEF
    \
    \ @brief TSC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TSC_TSCE                       \ [0x00] Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
    $01 constant TSC_START                      \ [0x01] Start a new acquisition This bit is set by software to start a new acquisition. It is cleared by hardware as soon as the acquisition is complete or by software to cancel the ongoing acquisition.
    $02 constant TSC_AM                         \ [0x02] Acquisition mode This bit is set and cleared by software to select the acquisition mode. Note: This bit must not be modified when an acquisition is ongoing.
    $03 constant TSC_SYNCPOL                    \ [0x03] Synchronization pin polarity This bit is set and cleared by software to select the polarity of the synchronization input pin.
    $04 constant TSC_IODEF                      \ [0x04] I/O Default mode This bit is set and cleared by software. It defines the configuration of all the TSC I/Os when there is no ongoing acquisition. When there is an ongoing acquisition, it defines the configuration of all unused I/Os (not defined as sampling capacitor I/O or as channel I/O). Note: This bit must not be modified when an acquisition is ongoing.
    $05 constant TSC_MCV                        \ [0x05 : 3] Max count value These bits are set and cleared by software. They define the maximum number of charge transfer pulses that can be generated before a max count error is generated. Note: These bits must not be modified when an acquisition is ongoing.
    $0c constant TSC_PGPSC                      \ [0x0c : 3] Pulse generator prescaler These bits are set and cleared by software.They select the AHB clock divider used to generate the pulse generator clock (PGCLK). Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the Section21.3.4: Charge transfer acquisition sequence for details.
    $0f constant TSC_SSPSC                      \ [0x0f] Spread spectrum prescaler This bit is set and cleared by software. It selects the AHB clock divider used to generate the spread spectrum clock (SSCLK). Note: This bit must not be modified when an acquisition is ongoing.
    $10 constant TSC_SSE                        \ [0x10] Spread spectrum enable This bit is set and cleared by software to enable/disable the spread spectrum feature. Note: This bit must not be modified when an acquisition is ongoing.
    $11 constant TSC_SSD                        \ [0x11 : 7] Spread spectrum deviation These bits are set and cleared by software. They define the spread spectrum deviation which consists in adding a variable number of periods of the SSCLK clock to the charge transfer pulse high state. ... Note: These bits must not be modified when an acquisition is ongoing.
    $18 constant TSC_CTPL                       \ [0x18 : 4] Charge transfer pulse low These bits are set and cleared by software. They define the duration of the low state of the charge transfer pulse (transfer of charge from CsubX/sub to CsubS/sub). ... Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the Section21.3.4: Charge transfer acquisition sequence for details.
    $1c constant TSC_CTPH                       \ [0x1c : 4] Charge transfer pulse high These bits are set and cleared by software. They define the duration of the high state of the charge transfer pulse (charge of CsubX/sub). ... Note: These bits must not be modified when an acquisition is ongoing.
  [then]


  [ifdef] TSC_TSC_IER_DEF
    \
    \ @brief TSC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAIE                      \ [0x00] End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
    $01 constant TSC_MCEIE                      \ [0x01] Max count error interrupt enable This bit is set and cleared by software to enable/disable the max count error interrupt.
  [then]


  [ifdef] TSC_TSC_ICR_DEF
    \
    \ @brief TSC interrupt clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAIC                      \ [0x00] End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0' has no effect.
    $01 constant TSC_MCEIC                      \ [0x01] Max count error interrupt clear This bit is set by software to clear the max count error flag and it is cleared by hardware when the flag is reset. Writing a '0' has no effect.
  [then]


  [ifdef] TSC_TSC_ISR_DEF
    \
    \ @brief TSC interrupt status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAF                       \ [0x00] End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
    $01 constant TSC_MCEF                       \ [0x01] Max count error flag This bit is set by hardware as soon as an analog I/O group counter reaches the max count value specified. It is cleared by software writing 1 to the bit MCEIC of the TSC_ICR register.
  [then]


  [ifdef] TSC_TSC_IOHCR_DEF
    \
    \ @brief TSC I/O hysteresis control register
    \ Address offset: 0x10
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TSC_G1_IO1                     \ [0x00] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $01 constant TSC_G1_IO2                     \ [0x01] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $02 constant TSC_G1_IO3                     \ [0x02] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $03 constant TSC_G1_IO4                     \ [0x03] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $04 constant TSC_G2_IO1                     \ [0x04] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $05 constant TSC_G2_IO2                     \ [0x05] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $06 constant TSC_G2_IO3                     \ [0x06] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $07 constant TSC_G2_IO4                     \ [0x07] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $08 constant TSC_G3_IO1                     \ [0x08] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $09 constant TSC_G3_IO2                     \ [0x09] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0a constant TSC_G3_IO3                     \ [0x0a] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0b constant TSC_G3_IO4                     \ [0x0b] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0c constant TSC_G4_IO1                     \ [0x0c] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0d constant TSC_G4_IO2                     \ [0x0d] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0e constant TSC_G4_IO3                     \ [0x0e] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0f constant TSC_G4_IO4                     \ [0x0f] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $10 constant TSC_G5_IO1                     \ [0x10] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $11 constant TSC_G5_IO2                     \ [0x11] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $12 constant TSC_G5_IO3                     \ [0x12] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $13 constant TSC_G5_IO4                     \ [0x13] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $14 constant TSC_G6_IO1                     \ [0x14] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $15 constant TSC_G6_IO2                     \ [0x15] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $16 constant TSC_G6_IO3                     \ [0x16] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $17 constant TSC_G6_IO4                     \ [0x17] Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
  [then]


  [ifdef] TSC_TSC_IOASCR_DEF
    \
    \ @brief TSC I/O analog switch control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $01 constant TSC_G1_IO2                     \ [0x01] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $02 constant TSC_G1_IO3                     \ [0x02] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $03 constant TSC_G1_IO4                     \ [0x03] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $04 constant TSC_G2_IO1                     \ [0x04] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $05 constant TSC_G2_IO2                     \ [0x05] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $06 constant TSC_G2_IO3                     \ [0x06] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $07 constant TSC_G2_IO4                     \ [0x07] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $08 constant TSC_G3_IO1                     \ [0x08] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $09 constant TSC_G3_IO2                     \ [0x09] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0a constant TSC_G3_IO3                     \ [0x0a] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0b constant TSC_G3_IO4                     \ [0x0b] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0c constant TSC_G4_IO1                     \ [0x0c] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0d constant TSC_G4_IO2                     \ [0x0d] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0e constant TSC_G4_IO3                     \ [0x0e] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $0f constant TSC_G4_IO4                     \ [0x0f] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $10 constant TSC_G5_IO1                     \ [0x10] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $11 constant TSC_G5_IO2                     \ [0x11] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $12 constant TSC_G5_IO3                     \ [0x12] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $13 constant TSC_G5_IO4                     \ [0x13] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $14 constant TSC_G6_IO1                     \ [0x14] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $15 constant TSC_G6_IO2                     \ [0x15] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $16 constant TSC_G6_IO3                     \ [0x16] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
    $17 constant TSC_G6_IO4                     \ [0x17] Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
  [then]


  [ifdef] TSC_TSC_IOSCR_DEF
    \
    \ @brief TSC I/O sampling control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $01 constant TSC_G1_IO2                     \ [0x01] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $02 constant TSC_G1_IO3                     \ [0x02] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $03 constant TSC_G1_IO4                     \ [0x03] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $04 constant TSC_G2_IO1                     \ [0x04] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $05 constant TSC_G2_IO2                     \ [0x05] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $06 constant TSC_G2_IO3                     \ [0x06] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $07 constant TSC_G2_IO4                     \ [0x07] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $08 constant TSC_G3_IO1                     \ [0x08] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $09 constant TSC_G3_IO2                     \ [0x09] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0a constant TSC_G3_IO3                     \ [0x0a] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0b constant TSC_G3_IO4                     \ [0x0b] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0c constant TSC_G4_IO1                     \ [0x0c] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0d constant TSC_G4_IO2                     \ [0x0d] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0e constant TSC_G4_IO3                     \ [0x0e] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0f constant TSC_G4_IO4                     \ [0x0f] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $10 constant TSC_G5_IO1                     \ [0x10] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $11 constant TSC_G5_IO2                     \ [0x11] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $12 constant TSC_G5_IO3                     \ [0x12] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $13 constant TSC_G5_IO4                     \ [0x13] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $14 constant TSC_G6_IO1                     \ [0x14] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $15 constant TSC_G6_IO2                     \ [0x15] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $16 constant TSC_G6_IO3                     \ [0x16] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $17 constant TSC_G6_IO4                     \ [0x17] Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
  [then]


  [ifdef] TSC_TSC_IOCCR_DEF
    \
    \ @brief TSC I/O channel control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $01 constant TSC_G1_IO2                     \ [0x01] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $02 constant TSC_G1_IO3                     \ [0x02] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $03 constant TSC_G1_IO4                     \ [0x03] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $04 constant TSC_G2_IO1                     \ [0x04] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $05 constant TSC_G2_IO2                     \ [0x05] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $06 constant TSC_G2_IO3                     \ [0x06] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $07 constant TSC_G2_IO4                     \ [0x07] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $08 constant TSC_G3_IO1                     \ [0x08] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $09 constant TSC_G3_IO2                     \ [0x09] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0a constant TSC_G3_IO3                     \ [0x0a] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0b constant TSC_G3_IO4                     \ [0x0b] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0c constant TSC_G4_IO1                     \ [0x0c] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0d constant TSC_G4_IO2                     \ [0x0d] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0e constant TSC_G4_IO3                     \ [0x0e] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $0f constant TSC_G4_IO4                     \ [0x0f] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $10 constant TSC_G5_IO1                     \ [0x10] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $11 constant TSC_G5_IO2                     \ [0x11] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $12 constant TSC_G5_IO3                     \ [0x12] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $13 constant TSC_G5_IO4                     \ [0x13] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $14 constant TSC_G6_IO1                     \ [0x14] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $15 constant TSC_G6_IO2                     \ [0x15] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $16 constant TSC_G6_IO3                     \ [0x16] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
    $17 constant TSC_G6_IO4                     \ [0x17] Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
  [then]


  [ifdef] TSC_TSC_IOGCSR_DEF
    \
    \ @brief TSC I/O group control status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1E                        \ [0x00] Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
    $01 constant TSC_G2E                        \ [0x01] Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
    $02 constant TSC_G3E                        \ [0x02] Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
    $03 constant TSC_G4E                        \ [0x03] Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
    $04 constant TSC_G5E                        \ [0x04] Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
    $05 constant TSC_G6E                        \ [0x05] Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
    $10 constant TSC_G1S                        \ [0x10] Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
    $11 constant TSC_G2S                        \ [0x11] Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
    $12 constant TSC_G3S                        \ [0x12] Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
    $13 constant TSC_G4S                        \ [0x13] Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
    $14 constant TSC_G5S                        \ [0x14] Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
    $15 constant TSC_G6S                        \ [0x15] Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
  [then]


  [ifdef] TSC_TSC_IOG1CR_DEF
    \
    \ @brief TSC I/O group 1 counter register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).
  [then]


  [ifdef] TSC_TSC_IOG2CR_DEF
    \
    \ @brief TSC I/O group 2 counter register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).
  [then]


  [ifdef] TSC_TSC_IOG3CR_DEF
    \
    \ @brief TSC I/O group 3 counter register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).
  [then]


  [ifdef] TSC_TSC_IOG4CR_DEF
    \
    \ @brief TSC I/O group 4 counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).
  [then]


  [ifdef] TSC_TSC_IOG5CR_DEF
    \
    \ @brief TSC I/O group 5 counter register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).
  [then]


  [ifdef] TSC_TSC_IOG6CR_DEF
    \
    \ @brief TSC I/O group 6 counter register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).
  [then]

  \
  \ @brief Touch sensing controller
  \
  $00 constant TSC_TSC_CR               \ TSC control register
  $04 constant TSC_TSC_IER              \ TSC interrupt enable register
  $08 constant TSC_TSC_ICR              \ TSC interrupt clear register
  $0C constant TSC_TSC_ISR              \ TSC interrupt status register
  $10 constant TSC_TSC_IOHCR            \ TSC I/O hysteresis control register
  $18 constant TSC_TSC_IOASCR           \ TSC I/O analog switch control register
  $20 constant TSC_TSC_IOSCR            \ TSC I/O sampling control register
  $28 constant TSC_TSC_IOCCR            \ TSC I/O channel control register
  $30 constant TSC_TSC_IOGCSR           \ TSC I/O group control status register
  $34 constant TSC_TSC_IOG1CR           \ TSC I/O group 1 counter register
  $38 constant TSC_TSC_IOG2CR           \ TSC I/O group 2 counter register
  $3C constant TSC_TSC_IOG3CR           \ TSC I/O group 3 counter register
  $40 constant TSC_TSC_IOG4CR           \ TSC I/O group 4 counter register
  $44 constant TSC_TSC_IOG5CR           \ TSC I/O group 5 counter register
  $48 constant TSC_TSC_IOG6CR           \ TSC I/O group 6 counter register

: TSC_DEF ; [then]
